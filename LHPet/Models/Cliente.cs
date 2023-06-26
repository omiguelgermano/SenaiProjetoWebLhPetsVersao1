using System.Reflection;

namespace LHPet.Models;

public class Cliente {
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Cpf { get; set; }
	public string? Email { get; set; }
	public string? Paciente { get; set; }

    public Cliente(int id, string nome, string cpf, string emil, string paciente)
    {
        this.Id = id;
		this.Name = nome;
		this.Cpf = cpf;
		this.Email = emil;
		this.Paciente = paciente;
    }
}