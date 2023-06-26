using System.Reflection;

namespace LHPet.Models;

public class Fornecedor {

	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Cnpj { get; set; }
	public string? Email { get; set; }

	public Fornecedor(int id, string nome, string cnpj, string email) {
		this.Id = id;
		this.Name = nome;
		this.Cnpj = cnpj;
		this.Email = email;

	}
}