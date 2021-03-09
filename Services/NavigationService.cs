
using GameQuest.Data;
using System.Collections.Generic;
using System.Linq;

public class NavigationService
{
    private Context _context;
    public NavigationService(Context context)
    {
        _context = context;
    }

    public List<Content> GetMenu()
    {
        return _context.Contents.Where(page => page.IsInMenu.Equals(true) && page.IsPublished.Equals(true)).ToList();
    }

}