using ProductionPlanner.Model;

namespace ProductionPlanner.Object
{
    internal class Manager
    {
        private string use_name;
        private string password;
        private bool edit_rights;

        public Manager(string use_name, string password, bool edit_rights)
        {
            Cryption cryption = new Cryption();
            this.use_name = cryption.getDecrypt(use_name);
            this.password = password;
            this.edit_rights = edit_rights;
        }

        public string Use_name { get => use_name; set => use_name = value; }
        public bool Edit_rights { get => edit_rights; set => edit_rights = value; }

        public string get_password()
        {
            Cryption cryption = new Cryption();
            return cryption.getMD5(password);
        }

        public int get_edit_right()
        {
            if (edit_rights)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
