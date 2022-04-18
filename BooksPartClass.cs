using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam22
{
    public partial class Books
    {
        public string img
        {
            get
            {
                if(Cover != null)
                {
                    return Cover;
                }
                else
                {
                    return "Img/no-image.png";
                }
            }
        }
    }
}
