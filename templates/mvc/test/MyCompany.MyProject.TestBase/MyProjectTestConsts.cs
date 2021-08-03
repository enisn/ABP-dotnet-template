namespace MyCompany.MyProject
{
    public static class MyProjectTestConsts
    {
#if MongoDb
        public const string CollectionDefinitionName = "MyProject collection";
#endif
    }
}
