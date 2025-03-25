using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager
{
    public class PanelControl
    {
        private Dictionary<Button, bool> buttonsDictionary;
        private List<Button> _buttons;

        public PanelControl(List <Button> buttons)
        { 
            _buttons = buttons;
            buttonsDictionary = new Dictionary<Button, bool>();

            foreach (var button in _buttons)
            {
                button.Click += (sender, e) => ChooseButton((Button)sender);
            }
        }

        public void AppendDictionary()
        {
            foreach (var button in _buttons)
            { 
                buttonsDictionary.Add(button, false);
            }
        }

        public void ChooseButton(Button selectedButton)
        {
            foreach (var button in buttonsDictionary.Keys)
            {
                if (button == selectedButton)
                {
                    buttonsDictionary[button] = true;
                    button.BackColor = Color.FromArgb(107, 61, 235);
                }
                else
                {
                    buttonsDictionary[button] = false;
                    button.BackColor = Color.FromArgb(26, 155, 131);
                }
            }
        }
    }
}
