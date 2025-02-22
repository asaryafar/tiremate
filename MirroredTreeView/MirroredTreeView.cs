using System.Windows.Forms ;
// using RGDataAccess;

//namespace Negasht.FormGenerator.UIProcess.UIControls 
namespace MirroredTreeView
{
	public class MirroredTreeView : TreeView 
	{
		private const int WS_EX_LAYOUTRTL = 0x400000;

		protected override CreateParams CreateParams 
		{
			get
			{
				if (RightToLeft == RightToLeft.Yes)
				{
					CreateParams cp;
					cp = base.CreateParams;
					cp.ExStyle = cp.ExStyle | WS_EX_LAYOUTRTL;
					return cp;
				}
				return base.CreateParams;
			}
		}
	}
}

