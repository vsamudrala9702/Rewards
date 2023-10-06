using Microsoft.AspNetCore.Mvc;
using CoustomerReward.Models;

namespace CoustomerReward.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateRewardsPointsController : ControllerBase   {


       
        [HttpPost(Name = "CalculateRewardPoints")]
        public  int CalculateRewardPoints([FromBody]Transaction transaction)
        {
            int rewardPoints = 0;

            if (transaction.Amount > 100)
            {
                rewardPoints += (int)((transaction.Amount - 100) * 2);
                transaction.Amount = 100;
            }

            if (transaction.Amount > 50)
            {
                rewardPoints += (int)(transaction.Amount - 50);
            }

            return rewardPoints;
        }
    }
}
