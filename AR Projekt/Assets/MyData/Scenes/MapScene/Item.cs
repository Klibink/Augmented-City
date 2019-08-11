public enum Item
{
    Messer,
    Axt,
    Speer
}

static class ItemHelper
{
    public static string GetPath(Item item)
    {
        switch (item)
        {
            case Item.Messer:
                return "messer.png";
            case Item.Axt:
                return "axt.png";
            case Item.Speer:
                return "speer.png";
            default:
                return "Item nicht bekannt";
        }
        
    }

    public static int GetSpriteIndex(Item item)
    {
        switch (item)
        {
            case Item.Messer:
                return 0;
            case Item.Axt:
                return 1;
            case Item.Speer:
                return 2;
            default:
                return 0;
        }

    }
}