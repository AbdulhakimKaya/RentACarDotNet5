using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageCountCorrect());

            if (result != null)
            {
                return result;
            }
            //carImage.Date = DateTime.Now;

            CarImage image = new CarImage
            {
                Id = carImage.Id,
                CarId = carImage.CarId,
                Date = DateTime.Now,
                ImagePath = Guid.NewGuid().ToString(),
            };
            string FilePath = "wwwroot\\images\\";
            
            
            _carImageDal.Add(image);
            return new SuccessResult();
        }

        public IResult Delete(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(),Messages.CarImageListed);
        }

        public IDataResult<List<CarImage>> GetImagesByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId), Messages.CarImageListed);
        }

        public IResult Update(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfCarImageCountCorrect()
        {
            var result = _carImageDal.GetAll().Count;

            if (result > 5)
            {
                return new ErrorResult(Messages.CarImageLimitedExceded);
            }
            return new SuccessResult();
        }
    }
}
