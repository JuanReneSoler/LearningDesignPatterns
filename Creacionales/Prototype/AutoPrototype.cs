

namespace patrones.Prototype
{
    public abstract class AutoPrototype
    {
	private string _color;
	private string _modelo;
	protected string _marca;

	public string Color {set => _color = value;}
	public string Modelo {set=> _modelo = value;}

	public AutoPrototype Clonar() => (AutoPrototype)this.MemberwiseClone();
	public string VerAuto() => $"{_marca} {_modelo} color: {_color}";
    }
}



