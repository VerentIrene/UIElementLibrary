using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progress_bar
{
    public class BuilderLoadingBar
    {
        public BuilderLoadingBar()
        {

        }

        public LoadingBar buildLoadingBar()
        {
            LoadingBar loadingBar = new LoadingBar();
            return loadingBar;
        }
    }
}
