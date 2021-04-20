using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindPowerSystemV3.Repositories.Models
{
	public class TurbineType
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public string Model { get; set; }

		[Required]
		public float Capacity { get; set; }
	}
}
