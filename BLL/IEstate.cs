namespace BLL

{
    public interface IEstate
    {

    //    int GetId();
        string GetCategory();

        string GetTypeEstate();

        string GetLegal();

     //   void SetId(int id);
        void SetCategory(string category);
        void SetType(string type);
        void SetLegal(string legal);



    }
}