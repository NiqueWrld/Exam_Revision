using System.ComponentModel.DataAnnotations;

namespace Exam_Revision.Models
{
    public class YouTubeModel
    {
        [Required]
        [Display(Name = "Name : ")]
        public string Name { get; set; }
        [Display(Name = "Surname : ")]
        public string Surname { get; set; }
        [Required]
        [Phone]
        [Display(Name = "Celphone Number : ")]
        public string celphoneNumber { get; set; }

        [Required]
        [Display(Name = "Facebook Followers : ")]
        public int noFacebookFollowers { get; set; }

        [Required]
        [Display(Name = "Instagram Followers : ")]
        public int noInstagramFollowers { get; set; }

        [Required]
        [Display(Name = "Twitter Followers : ")]
        public int noTwitterFollowers { get; set; }

        [Required]
        [Display(Name = "Pinterest Followers : ")]
        public int noPinterestFollowers { get; set; }

        [Display(Name = "Highest Followers : ")]
        public string highestFollowers { get; set; }

        public string getHighestFollowers()
        {
            int highestFollowers = Math.Max(Math.Max(noFacebookFollowers, noInstagramFollowers), Math.Max(noTwitterFollowers, noPinterestFollowers));

            List<string> platforms = new List<string>();

            if (highestFollowers == noFacebookFollowers)
            {
                platforms.Add("Facebook");
            }

            if (highestFollowers == noInstagramFollowers)
            {
                platforms.Add("Instagram");
            }

            if (highestFollowers == noTwitterFollowers)
            {
                platforms.Add("Twitter");
            }
            if (highestFollowers == noPinterestFollowers)
            {
                platforms.Add("Pinterest");
            }

            // Join the platforms with the same highest followers into a single string
            return string.Join(", ", platforms);
        }

        //public string getHighestFollowers()
        //{
        //    int highestFollowers = Math.Max(Math.Max(noFacebookFollowers, noInstagramFollowers), Math.Max(noTwitterFollowers, noPinterestFollowers));

        //    if (highestFollowers == noFacebookFollowers)
        //    {
        //        return "Facebook";
        //    }
        //    else if (highestFollowers == noInstagramFollowers)
        //    {
        //        return "Instagram";
        //    }
        //    else if (highestFollowers == noTwitterFollowers)
        //    {
        //        return "Twitter";
        //    }
        //    else
        //    {
        //        return "Pinterest";
        //    }

            
        //}

    }
}
