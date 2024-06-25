namespace CleanArchitecture.API.Contracts.V1
{
    public class ApiRoutes
    {
        /// <summary>
        /// root
        /// </summary>
        public const string Root = "api";
        /// <summary>
        /// version
        /// </summary>
        public const string Version = "v1";
        /// <summary>
        /// base
        /// </summary>
        public const string Base = Root + "/" + Version;

        #region Product
        /// <summary>
        /// The Identity class that defines the Identity endpoint routes test
        /// </summary>
        public static class Product
        {
            public const string GetAllProducts = "get-all-products";
            public const string GetProductById = "get-product-by-id";
            public const string CreateProduct = "create-product";
            public const string UpdateProduct = "update-product";
            public const string SoftDeleteProduct = "soft-delete-product";
            public const string SoftDeleteProductt = "soft-delete-productt";
        }
        #endregion
        
    }
}
