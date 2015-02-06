using Cento.Core.Project;
using System.Drawing;
using System.IO;

public partial class CentoProjectDataImage
{
    #region Members

    private Image _image = null;

    #endregion

    #region Properties

    public Image Image
    {
        get
        {
            if (this._image == null)
            {
                LoadImage();
            }

            return this._image;
        }
    }

    #endregion

    #region Methods

    private void LoadImage()
    {
        string projectDirectory = CentoCore.Instance.ProjectFolderPath;
        this._image = Image.FromFile(Path.Combine(projectDirectory, this.Filename));
    }

    #endregion
}
