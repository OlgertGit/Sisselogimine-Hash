using System.Windows.Forms;

namespace SisseLogimine.Klassid
{
public interface IMessageService
{
    void MessageInfo(string text, string caption);
    void MessageExclamation(string text, string caption);
    void MessageError(string text, string caption);

}

public class MessageService : IMessageService
{
    public void MessageInfo(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    public void MessageExclamation(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    public void MessageError(string text, string caption)
    {
        MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
}
