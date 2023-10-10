using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppThemeBug
{
    public class AppShellViewModel
    {

        public ObservableCollection<Domain> Domains { get; set; } = new(new[] {new Domain() {Name = "Home"}, new Domain() {Name = "Settings"}});
    }

    public class Domain
    {
        public string Name { get; set; }
    }
}
