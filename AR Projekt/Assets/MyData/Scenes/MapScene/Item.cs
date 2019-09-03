public enum Item
{
    Krone,
    Feder,
    Spiegel
}

static class ItemHelper
{
    public static string GetPath(Item item)
    {
        switch (item)
        {
            case Item.Krone:
                return "messer.png";
            case Item.Feder:
                return "axt.png";
            case Item.Spiegel:
                return "speer.png";
            default:
                return "Item nicht bekannt";
        }
        
    }

    public static int GetSpriteIndex(Item item)
    {
        switch (item)
        {
            case Item.Krone:
                return 0;
            case Item.Feder:
                return 1;
            case Item.Spiegel:
                return 2;
            default:
                return 0;
        }

    }
}