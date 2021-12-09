using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entittes
{
    public class Camera
    {
        public int CameraID { get; set; }
        public string CameraName { get; set; }
        public string CameraDescription { get; set; }
        public int CameraPrice { get; set; }
        public CameraCategory CameraCategory { get; set; }
        public List<CameraMedia> CamerapMedia { get; set; }
        public DateTime CameraInsertTime { get; set; }
    }
}
