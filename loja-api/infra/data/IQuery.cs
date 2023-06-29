namespace loja_api.infra.data;

public interface IQuery<T>
{
	IEnumerable<T> GetAll();
	T GetById(int id);
}