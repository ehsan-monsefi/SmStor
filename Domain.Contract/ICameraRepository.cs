using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ICameraRepository
    {
        Camera Get(int CameraId);
        (List<Camera>, int Count) GetFilterCameras(string Camerasearch, string Cameracategory, int CamerapageNumber, int CameraPageSize);
        List<Camera> GetChippsetCamera();
        List<Camera> GetNewstCamera();
    }
}
