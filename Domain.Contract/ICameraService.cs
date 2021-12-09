using Domain.Entittes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Contract
{
    public interface ICameraService
    {
        Camera Get(int CameraId);
        (List<Camera>, int Count) CameraSearch(string q, string Cameracategory, int CamerapageNumber, int CameraPageSize);
        List<Camera> GetChippsetCamera();
        List<Camera> GetNewstCamera();
    }
}
