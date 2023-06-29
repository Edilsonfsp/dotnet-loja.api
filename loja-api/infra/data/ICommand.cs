namespace loja_api.infra.data;
public interface ICommand<T>
{
	void Add(T obj);
	void Modify(T obj);
	void Remove(T obj);
}

