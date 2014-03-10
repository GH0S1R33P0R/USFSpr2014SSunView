﻿
namespace SeniorProject
{
    public interface ISimilarity
    {
        /// <summary>
        /// Approximate the Kolmogorov Complexity of an entity.
        /// </summary>
        /// <param name="entity">A compressable entity</param>
        /// <returns>Return an integer representation of the entity's complexity.</returns>
        int GetComplexity(ICompressible entity);

        /// <summary>
        /// Approximate the Normalized Information Distance between two entities.
        /// </summary>
        /// <param name="entity1">A compressable entity</param>
        /// <param name="entity2">Another compressable entity</param>
        /// <returns>Return a real number representing the similarity between entity1 and entity2.</returns>
        double GetSimilarity(ICompressible entity1, ICompressible entity2);

        /// <summary>
        /// Orders a list of enities according to each entities similarity to a given entity.
        /// </summary>
        /// <param name="entity">A compressable entity</param>
        /// <param name="dataSet">A list of compressable entities</param>
        /// <returns>Returns an orderd list of similar entities.</returns>
        ICompressible[] FindSimilarEntities(ICompressible entity, ICompressible[] dataSet);
    }
}