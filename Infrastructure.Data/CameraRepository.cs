using Domain.Contract;
using Domain.Entittes;
using Infrastructure.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data
{
    public class CameraRepository : ICameraRepository
    {
        private readonly SmContext context;
        public CameraRepository(SmContext context)
        {
            this.context = context;
        }
        public Camera Get(int CameraId)
        {
            return context.Cameras.Include(a => a.CamerapMedia).First(a => a.CameraID == CameraId);
        }

        public List<Camera> GetChippsetCamera()
        {
            return context.Cameras.Include(a => a.CamerapMedia).OrderByDescending(a => a.CameraInsertTime).ToList();
        }

        public (List<Camera>, int Count) GetFilterCameras(string Camerasearch, string Cameracategory, int CamerapageNumber, int CameraPageSize)
        {
            IQueryable<Camera> query = context.Cameras.Include(a => a.CamerapMedia);
            if (!string.IsNullOrEmpty(Camerasearch))
            {
                query = query.Where(a => a.CameraName.Contains(Camerasearch) || a.CameraDescription.Contains(Camerasearch));
            }
            if (Cameracategory != "All")
            {
                query = query.Where(a => a.CameraCategory.CameraCategoryName == Cameracategory);
            }
            var lengthQuery = query.ToList().Count;
            return (query.Skip((CamerapageNumber - 1) * CameraPageSize).Take(CameraPageSize).ToList(), lengthQuery);
        }

        public List<Camera> GetNewstCamera()
        {
            throw new NotImplementedException();
        }
    }
}
