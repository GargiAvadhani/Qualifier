public class Service:Detergent
{
    //Implement your code here

    public bool ValidateBillId()
    {
        if (BillId.Length !=5 || BillId[2] != ':')
        {
            return false;
        }

        string prefix = BillId.SubString(0,2);
        string suffix = BillId.Substring(3,2);

        if (!int.TryParse(prefix, out int prefixNumber))
        {
            return false;
        }

        if (!char.IsUpper(suffix[0]) || !char.IsUpper(suffix[1]))
        {
            return false;
        }
        return true;
    }
    public double CalculateTotalCost(float quantity)
    {
        double totalCost = CostPerPack*(quantity*1000)/GramsInPack;
        return totalCost;
    }
}