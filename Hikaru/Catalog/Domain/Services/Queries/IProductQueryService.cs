using Hikaru.Catalog.Domain.Model.Aggregates;
using Hikaru.Catalog.Domain.Model.Queries;

namespace Hikaru.Catalog.Domain.Services.Queries;

public interface IProductQueryService
{
    //Crear producto (done)
    //Eliminar Producto (done)
    //Actualizar Producto (done)
    //Obetner Producto Por id (done)
    //Obtener todos los productos (done)
    //Obtener todos los productos de una categoria(done)
    //Obtener todos los productos de una subcategoria(done)
    Task<IEnumerable<Product>> Handle(GetAllProductsQuery query);
    Task<Product?> Handle(GetProductByIdQuery query);
    Task<IEnumerable<Product>> Handle(GetProductsBySubcategoryQuery query);
}