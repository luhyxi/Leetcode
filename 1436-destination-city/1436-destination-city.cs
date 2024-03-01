public class Solution {
    public string DestCity(IList<IList<string>> paths) 
    {
        var check = new HashSet<string>();

        foreach (var path in paths) check.Add(path[1]);
        foreach (var path in paths) check.Remove(path[0]);
        return check.First();
    }
}