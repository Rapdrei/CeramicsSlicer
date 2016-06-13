using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace CeramicsSlicer
{
    public class CeramicsSlicerInfo : GH_AssemblyInfo
    {
        public override string Name => "CeramicsSlicer";
        public override Bitmap Icon => null;
        public override string Description => "";
        public override Guid Id => new Guid("e21b8242-9bef-4c5d-9ec8-145b68aca0c0");
        public override string AuthorName => "Dennis Groß, Phillipp Reichert";
        public override string AuthorContact => "gdennis91@googlemail.com, prei@me.com";
    }
}
