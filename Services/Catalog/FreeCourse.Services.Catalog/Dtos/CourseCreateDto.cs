namespace FreeCourse.Services.Catalog.Dtos
{
    public class CourseCreateDto
    {
        public string Name { get; set; }

        public string Decription { get; set; }

        public decimal Price { get; set; }

        public string picture { get; set; }


        public string UserId { get; set; }

        public FeatureDto Feature { get; set; }

        public string CategoryId { get; set; }

    }


}
