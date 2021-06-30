﻿using MelonLoader;
using Harmony;

using Assets.Scripts.Unity.UI_New.InGame.Races;
using Assets.Scripts.Simulation.Towers.Weapons;

using Assets.Scripts.Simulation;
using Assets.Scripts.Unity.UI_New.InGame;

using Assets.Scripts.Unity.UI_New.Main;

using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Models.Towers;

using Assets.Scripts.Unity;




using Assets.Scripts.Simulation.Towers;


using Assets.Scripts.Utils;


//using Il2CppSystem.Collections;


using Assets.Scripts.Unity.UI_New.Popups;
using System.Reflection;
using Assets.Scripts.Models;
using System.Collections.Generic;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;
using Assets.Scripts.Models.GenericBehaviors;
using System;
using System.Linq;
using Assets.Scripts.Models.ServerEvents;
using Assets.Scripts.Data.Cosmetics.Pets;
using Assets.Main.Scenes;
using UnhollowerBaseLib;

using Assets.Scripts.Models.Rounds;
using Assets.Scripts.Models.Store;
using Assets.Scripts.Unity.Bridge;
using Assets.Scripts.Models.Map;
using UnityEngine;
using System.IO;
using UnhollowerRuntimeLib;
using Assets.Scripts.Models.Map.Spawners;

namespace custommaps.Maps
{
    class ConcreteAlley
    {

        public static System.Random r = new System.Random();
        public static Il2CppReferenceArray<PointInfo> track1()
        {
            List<PointInfo> list = new List<PointInfo>();
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.5185f, -114.787f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.5185f, -62.39803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.92593f, -62.39803f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-55.92593f, 8.092535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.3333f, 8.092535f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-103.3333f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.148145f, 70.27775f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(-3.148145f, -11.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(49.44445f, -11.71296f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(49.44445f, -94.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(109.0741f, -94.55549f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(109.0741f, 40.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.03704f, 40.88887f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(52.03704f, 102.6482f) });
            list.Add(new PointInfo() { bloonScale = 1, bloonsInvulnerable = false, distance = 1, id = r.NextDouble() + "", moabScale = 1, moabsInvulnerable = false, rotation = 0, point = new Assets.Scripts.Simulation.SMath.Vector3(147.5926f, 102.6482f) });
            return list.ToArray();
        }

        public static Il2CppReferenceArray<AreaModel> areas()
        {
            List<AreaModel> newareas = new List<AreaModel>();
            var area0 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(150.1852f, -114.787f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.6296f, 115f));
            area0.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, 114.787f));
            newareas.Add(new AreaModel("lol0", new Assets.Scripts.Simulation.SMath.Polygon(area0), 10, (AreaType)2));
            var area1 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.33334f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.51852f, -77.30563f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.55556f, -76.2407f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-45.92593f, 15.97225f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-92.96297f, 16.18521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.33334f, 56.00929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.40741f, 55.58338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-12.40741f, -27.68521f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.55556f, -28.53704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(40.37038f, -110.3148f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, -107.9723f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(119.4445f, 49.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.48149f, 49.40746f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(61.66668f, 87.95366f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(148.3333f, 88.80549f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 109.8889f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.77779f, 110.102f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(42.22223f, 27.25929f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.5556f, 26.83338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(100.7408f, -87.52775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(60f, -87.52775f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(59.25927f, -5.749859f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.851847f, -5.537042f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(6.851847f, 77.9445f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, 77.73154f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.2222f, -6.388873f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-65.00001f, -7.240704f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-64.62964f, -54.94437f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, -55.58338f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.037f, -114.787f));
            area1.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.14816f, -114.787f));
            newareas.Add(new AreaModel("lol1", new Assets.Scripts.Simulation.SMath.Polygon(area1), 100f, AreaType.unplaceable, 0f, null, null, null, false, false, default));
            var area2 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.07409f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-80.37038f, 111.1668f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.37038f, 110.3148f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-72.96297f, 104.9908f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-75.37038f, 98.81493f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-78.8889f, 96.47225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-81.2963f, 97.32408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.96297f, 97.32408f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-82.96297f, 92.85183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-84.07408f, 89.23154f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-86.29631f, 87.10183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-89.81483f, 87.52789f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-93.14816f, 90.72225f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-99.62965f, 87.10183f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-103.8889f, 87.7407f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-107.037f, 80.28704f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.5926f, 80.71296f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-112.963f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-149.8148f, -114.787f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-150f, 115f));
            area2.Add(new Assets.Scripts.Simulation.SMath.Vector2(-79.44444f, 115f));
            newareas.Add(new AreaModel("lol2", new Assets.Scripts.Simulation.SMath.Polygon(area2), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area3 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.7408f, 84.97225f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.3704f, 36.2038f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.8519f, 34.07409f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.4815f, -86.25f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(122.4074f, -89.65746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(121.6667f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(149.0741f, -114.787f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(147.963f, 83.90746f));
            area3.Add(new Assets.Scripts.Simulation.SMath.Vector2(130.5556f, 84.33338f));
            newareas.Add(new AreaModel("lol3", new Assets.Scripts.Simulation.SMath.Polygon(area3), 100f, AreaType.unplaceable, 0f, null, null, null, true, false, default));
            var area4 = new Il2CppSystem.Collections.Generic.List<Assets.Scripts.Simulation.SMath.Vector2>();
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.85185f, 27.47225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.70372f, 28.11113f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.48149f, 23.63887f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(86.29631f, 15.54634f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.5926f, 1.703662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.5926f, -11.71296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, -22.78704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(96.4815f, -33.64803f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(95.55556f, -44.93507f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, -57.28704f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(97.40742f, -70.06479f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(92.77778f, -79.43521f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(87.22223f, -82.62958f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.2963f, -83.05549f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(72.77778f, -79.86098f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(67.96297f, -74.96296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.07408f, -59.41662f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.33334f, -31.30563f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.07408f, -12.35183f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(63.8889f, -3.83324f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(64.81482f, 5.537042f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(66.66667f, 13.20366f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(71.66666f, 16.82422f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(78.51853f, 17.46296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(80.74074f, 17.46296f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(82.77779f, 23.85197f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(81.48149f, 27.47225f));
            area4.Add(new Assets.Scripts.Simulation.SMath.Vector2(88.14816f, 27.25929f));
            newareas.Add(new AreaModel("lol4", new Assets.Scripts.Simulation.SMath.Polygon(area4), 10, (AreaType)1));

            return newareas.ToArray();


        }

        public static PathSpawnerModel spawner()
        {
            return new PathSpawnerModel("", new SplitterModel("", new string[]
                    {
                        "Path1",
                    }), new SplitterModel("", new string[]
                    {
                        "Path1",
                    }));
        }

        public static PathModel[] pathmodel()
        {
            return new PathModel[]
                    {
                        new PathModel("Path1", track1(), true, false, new Assets.Scripts.Simulation.SMath.Vector3(), new Assets.Scripts.Simulation.SMath.Vector3(), null, null),
                    };
        }


    }
}