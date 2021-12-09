using System.Collections.Generic;

namespace Domain.Entittes
{
    public class CameraCategory
    {
        public int CameraCategoryId { get; set; }
        public string CameraCategoryName { get; set; }
        public List<Camera> Cameras { get; set; }
    }
}
