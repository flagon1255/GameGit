using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListHolder 
{
    public static List<Hiscores> hs = new List<Hiscores>();

    public static void setlist(List<Hiscores> list)
    {
        hs = list;
    }

    public static List<Hiscores> returnList()
    {
        return hs;
    }
}
