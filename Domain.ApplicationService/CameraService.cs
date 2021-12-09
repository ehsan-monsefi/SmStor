using Domain.Contract;
using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.ApplicationService
{
    public class CameraService : ICameraService
    {
        private readonly ICameraRepository cameraRepository;
        public CameraService(ICameraRepository cameraRepository)
        {
            this.cameraRepository = cameraRepository;
        }
        public (List<Camera>, int Count) CameraSearch(string q, string Cameracategory, int CamerapageNumber, int CameraPageSize)
        {
            return cameraRepository.GetFilterCameras(q, Cameracategory, CamerapageNumber, CameraPageSize);
        }

        public Camera Get(int CameraId)
        {
            throw new NotImplementedException();
        }

        public List<Camera> GetChippsetCamera()
        {
            return cameraRepository.GetChippsetCamera().ToList();
        }

        public List<Camera> GetNewstCamera()
        {
            throw new NotImplementedException();
        }
    }
}
