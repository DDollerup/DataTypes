using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class DanielsTank
    {
        string tankName = "Daniels Tank";
        int health = 1000;
        bool alive = true;

        void Main(string[] args)
        {

            if (health <= 0)
            {

            }

            if (health >= 500 && health <= 750)
            {

            }

            if (health < 200 || health > 100)
            {

            }


            if (health <= 0)
            {
                // Dead
            }
            else if (health > 0 && health < 500)
            {
                // Print health as Red
            }
            else
            {
                // Alive
            }

            if (LessThanHundrethHealth())
            {

            }



        }

        void Shoot()
        {
            // Få tanken til at skyde
        }

        bool LessThanHundrethHealth()
        {
            if (health < 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void HealthPickup()
        {
            health += 100;
            if (health > 1000)
            {
                health = 1000;
            }
        }

        void TakeDamage(int amount)
        {
            health -= amount;
            if (health <= 0)
            {
                alive = false;
            }
        }

        void OnBeingHit()
        {
            TakeDamage(33);
        }
    }
}
