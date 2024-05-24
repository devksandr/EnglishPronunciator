namespace EnglishPronunciator.Models
{
    public class ExecuteCombinationModel
    {
        public CheckBox CtrlCheckBox { get; }
        public CheckBox ShiftCheckBox { get; }
        public CheckBox AltCheckBox { get; }
        public TextBox LetterTextBox { get; }

        public ExecuteCombinationModel(
            CheckBox ctrlCheckBox, 
            CheckBox shiftCheckBox, 
            CheckBox altCheckBox,
            TextBox letterTextBox
            ) => (CtrlCheckBox, ShiftCheckBox, AltCheckBox, LetterTextBox) =
                (ctrlCheckBox, shiftCheckBox, altCheckBox, letterTextBox);
    }
}
