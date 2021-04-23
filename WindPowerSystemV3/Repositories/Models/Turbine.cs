using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV3.Repositories.Models
{
	public class Turbine
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		public string SerialNum { get; set; }

		[Required]
		public int ProdMW { get; set; }

		[Required]
		public int TurbineTypeId { get; set; }


		#region Lazy-Load Properties

		[ForeignKey("TurbineTypeId")]
		public virtual TurbineType TurbineType { get; set; }
		
		#endregion
	}
}
