using Academia76721.Domain.Common;

namespace Academia76721.Domain.Entities
{
    /// <summary>
    /// Representa um Actor
    /// </summary>
    public class Actor : Person
    {
        public Actor()
        {
            this.Id = 0;
        }
        /// <summary>
        /// Papel desempenhado no filme.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 1 Actor pode estar em varios filmes
        /// </summary>
        public IList<Movie> Movies { get; set; }

    }
}