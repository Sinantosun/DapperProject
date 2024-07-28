namespace DapperProject.Dtos.FeatureDtos
{
    public class UpdateFeatureDto
    {
        public int FeatureId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string IframeUrl { get; set; }
    }
}
