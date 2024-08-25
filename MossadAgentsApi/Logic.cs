using MossadAgentsApi.Models;

namespace MossadAgentsApi
{
    public class Logic
    {
        public enum Direction
        {
            NW,
            N,
            NE,
            E,
            SE,
            S,
            SW,
            W
        }

        public List<Mission> AgentToTarget(List<Agent> agents, List<Target> targets)
        {
            List<Mission> CurrentMissions = new List<Mission>();
            foreach (Agent agent in agents)
            {
                foreach (Target target in targets)
                {
                    if (!agent.Status)
                    {
                        double Distance = Math.Sqrt(Math.Pow(Convert.ToDouble(agent.x) - Convert.ToDouble(target.x), 2) + Math.Pow(Convert.ToDouble(agent.y) - Convert.ToDouble(target.y), 2));
                        if (Distance <= 200)
                        {
                            Mission mission = new Mission();
                            mission.agentId = agent.Id;
                            mission.targetId = target.Id;
                            mission.TimeToTarget = Convert.ToInt32(Distance / 40);
                            CurrentMissions.Add(mission);
                        }
                    }

                }
            }

            return CurrentMissions;
        }

        public void MoveAgentOrTarget(ref int x, ref int y, Direction direction)
        {
            switch (direction)
            {
                case Direction.NW:
                    {
                        x--; y++;
                    }
                    break;
                case Direction.N:
                    {
                        y++;
                    }
                    break;
                case Direction.NE:
                    {
                        x++; y++;
                    }
                    break;
                case Direction.E:
                    {
                        x++;
                    }
                    break;
                case Direction.SE:
                    {
                        x++; y--;
                    }
                    break;
                case Direction.S:
                    {
                        y--;
                    }
                    break;
                case Direction.SW:
                    {
                        x--; y--;
                    }
                    break;
                case Direction.W:
                    {
                        x--; ;
                    }
                    break;
                default:

                    break;
            }
        }

        public Agent MoveAgentToTarget(ref Agent agent, Target target)
        {
            if (agent.x > target.x)
            {
                agent.x--;
            }
            if (agent.x > target.x)
            {
                agent.x++;
            }
            if (agent.y > target.y)
            {
                agent.y--;
            }
            if (agent.y < target.y)
            {
                agent.y++;
            }
        }
    }
}
