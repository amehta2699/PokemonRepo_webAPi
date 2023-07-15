// DTO's are used to limit the data send to frontend
// return only that data from api that is necessary

using System;
namespace PokemonReviewApp.Dto
{
	public class PokemonDto
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}

