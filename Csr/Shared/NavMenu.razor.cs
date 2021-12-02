using MudBlazor;
namespace Csr.Shared
{
    public partial class NavMenu
    {
        public enum MenuType
        {
            Group,
            Program
        }
        public class MenuModel
        {
            public MenuType MenuType { get; set; }
            public float SortNo { get; set; }
            public string MenuID { get; set; }
            public string MenuName { get; set; }
            public string Href { get; set; }
            public string IconPath { get; set; }
            public Color IconColor { get; set; }
            public List<MenuModel> SubMenus { get; set; }
        }

        public List<MenuModel> menuModels = new();

        private string GetIconPath(string stringIconPath)
        {
            string[] iconPaths = stringIconPath.Replace("Icons.","").Split(".");
            var filed = typeof(Icons).GetField(iconPaths[0]);
            var prop = filed.GetValue(filed);
            var iconPath = prop.GetType().GetProperty(iconPaths[1]).GetValue(prop).ToString();
            return iconPath;
        }
        private Color GetColor(string stringColor) {
            string enumString = stringColor.Replace("Color.","");
            return (Color)Enum.Parse(typeof(Color), enumString);
        }

        //protected override void OnInitialized()
        //{
        //    base.OnInitialized();
            
        //    /*
        //    MenuModel menuModel = new MenuModel
        //    {
        //        MenuType = MenuType.Program,
        //        SortNo = 1f,
        //        MenuID = "M001",
        //        MenuName = "Home",
        //        Href = "/home",
        //        IconPath = GetIconPath("Icons.Filled.Home"),
        //        IconColor = GetColor("Color.Primary")
        //    };
        //    menuModels.Add(menuModel);
        //    MenuModel menuModel1 = new MenuModel
        //    {
        //        MenuType = MenuType.Program,
        //        SortNo = 2f,
        //        MenuID = "M002",
        //        MenuName = "접수목록",
        //        Href = "/counter",
        //        IconPath = GetIconPath("Icons.Filled.Ballot"),
        //        IconColor = GetColor("Color.Info")
        //    };
        //    menuModels.Add(menuModel1);
        //    List<MenuModel> subMenus = new List<MenuModel>();
        //    subMenus.Add(new MenuModel
        //    {
        //        MenuType = MenuType.Program,
        //        SortNo = 4f,
        //        MenuID = "M004",
        //        MenuName = "고객사관리",
        //        Href = "/settings/customers",
        //        IconPath = Icons.Filled.AccountCircle,
        //        IconColor = GetColor("Color.Info")
        //    });
        //    subMenus.Add(new MenuModel
        //    {
        //        MenuType = MenuType.Program,
        //        SortNo = 5f,
        //        MenuID = "M005",
        //        MenuName = "프로젝트관리",
        //        Href = "/settings/projects",
        //        IconPath = Icons.Filled.AccountBalanceWallet,
        //        IconColor = GetColor("Color.Info")
        //    });
        //    subMenus.Add(new MenuModel
        //    {
        //        MenuType = MenuType.Program,
        //        SortNo = 6f,
        //        MenuID = "M006",
        //        MenuName = "사용자관리",
        //        Href = "/settings/users",
        //        IconPath = Icons.Filled.People,
        //        IconColor = GetColor("Color.Success")  
        //    });
        //    MenuModel menuModel2 = new MenuModel
        //    {
        //        MenuType = MenuType.Group,
        //        SortNo = 3f,
        //        MenuID = "M003",
        //        MenuName = "시스템관리",
        //        Href = "",
        //        IconPath = Icons.Filled.Settings,
        //        IconColor = GetColor("Color.Info"),
        //        SubMenus = subMenus
        //    };
        //    menuModels.Add(menuModel2);
        //    */
        //}

    }
}
