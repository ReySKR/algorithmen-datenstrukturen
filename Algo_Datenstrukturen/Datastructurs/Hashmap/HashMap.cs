namespace Algo_Datenstrukturen.Datastructurs;

//Implementiert mit Chaining Verfahren NICHT mit Lineare Sondierung!
public class HashMap<T_Key, T_Value>
    where T_Key : struct 
{
    public List<HashMapItem<T_Key, T_Value>>[] Map { get; }
    

    public HashMap(params HashMapItem<T_Key, T_Value>[] items)
    {
        //7:10 Lastfaktor
        int initialLength = (int)Math.Ceiling(items.Length / 7.0) * 10;
        Map = new List<HashMapItem<T_Key, T_Value>>[initialLength];
        
        
    }

    //Aktuelle Annahme. Ist ein ValueType
    public int hashFunction(T_Key keyToHash)
    {
        int numberToHash = 0;
        return 0;
    }
}