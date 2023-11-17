using System.Collections.Generic;
using System.Windows.Forms;

namespace BalonDor
{
    public partial class Form3 : Form
    {
        Dictionary<string, int> BalonDor;
        public Form3(Dictionary<string, int> BalonDor)
        {
            InitializeComponent();
            
            this.BalonDor = BalonDor;
        }
        
        
    }
}