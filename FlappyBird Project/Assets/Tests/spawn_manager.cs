using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;


namespace Tests
{
    public class spawn_manager
    {
        // A Test behaves as an ordinary method
        [Test]
        public void first_obstacle_coordinate_test()
        {
            // Use the Assert class to test conditions
            Vector3 result = SpawnObstacle.generateObstacleCoords(1);

            Assert.AreEqual(2.753f, result.x);
            Assert.LessOrEqual(result.y, 5);
            Assert.GreaterOrEqual(result.y, -5);
            Assert.AreEqual(29, result.z);
        }


        [Test]
        public void first_tree_coordinate_generation_test()
        {
            Vector3 spawnCoord = SpawnTree.generateTreeCoords();

            Assert.AreEqual(-8.4f, spawnCoord.y);
            Assert.AreEqual(100.0f, spawnCoord.z);

            float absval_x = Mathf.Abs(spawnCoord.x);
            Assert.GreaterOrEqual(absval_x, 8);
            Assert.LessOrEqual(absval_x, 25);
        }


    }
}

