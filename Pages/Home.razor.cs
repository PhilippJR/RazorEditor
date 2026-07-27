namespace RazorEditor.Pages

{
    public partial class Home
    {
        readonly bool _bool1 = true;
        readonly bool _bool2 = true;
        readonly bool _bool3 = true;

        public string MyString { get; set; } = "";


        // VS 18.5: I expected CTRL+K,D to align the undescores.
        // VS 18.6: I expected CTRL+K,D to align the undescores.
        // VS 18.7: I expected CTRL+K,D to align the undescores.
        private void MyMethod()
        {
            if (_bool1 ||
_bool2 ||
_bool3)
            {

}
        }
    }
}