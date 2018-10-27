using System;
using System.Dynamic;

namespace OnePunch
{
	public class Enemy
	{
		private string _name;
		private int _hp;
		private int _damage;
		
		public Enemy(int health, int damage, string name)
		{
			_name = name;
			_hp = health;
			_damage = damage;
		}

		public int GetHp()
		{
			return _hp;
		}

		public void SetHp(int newHp)
		{
			_hp = newHp;
		}

		public int GetDamage()
		{
			return _damage;
		}

		public void SetDamage(int newDamage)
		{
			_damage = newDamage;
		}

		public void IsDead()
		{
			if (_hp <= 0)
			{
				Console.WriteLine("Вы убили врага {0}", _name);
			}
			else
			{
				Console.WriteLine("Враг еще не умер {0}", _name);
			}
		}
	}

	class GeneralizedPerson<T> where T : new()
	{
		private static T _person;

		private static T CreateInstance()
		{
			return new T();
		}

		public static T GetInstance()
		{
			if (_person != null)
			{
				return _person;
			}

			_person = CreateInstance();
			return _person;
		}

	}

	class Person: GeneralizedPerson<Person>
	{
		const int Maxhp = 300;
		public int Hp { get; private set; } = Maxhp;
		private int Strength { get; } = 100;

		public void Heal(int healPoints)
		{
			if(Hp + healPoints >= Maxhp)
			{
				Hp = Maxhp;
				int saturatedHeal = Maxhp - Hp;
				Console.WriteLine("Похилилися на {0}", saturatedHeal);
			}
			else
			{
				Hp += healPoints;
				Console.WriteLine("Похилилися на {0}", healPoints);
			}

		}

		public void Damage(Enemy enemy)
		{
			int damage = enemy.GetDamage();
			if (Hp - damage <= 0)
			{
				Hp = 0;
			}
			else
			{
				Hp -= damage;
			}
		}

		public void Damage(int damage)
		{
			if (Hp - damage <= 0)
			{
				Hp = 0;
			}
			else
			{
				Hp -= damage;
			}
		}
		
		public void Respawn() 
		{
			if (Hp == 0)
			{
				Hp = Maxhp;
			}
			else
			{
				Console.WriteLine("Зачем воскрешать, если герой и так нормально себя чувствует");
			}
		}

		public void Attack(Enemy enemy)
		{
			if (Hp != 0)
			{
				int enemyHp = enemy.GetHp();
				enemyHp -= Strength;
				enemy.SetHp(enemyHp);
				enemy.IsDead();
			}
			else
			{
				Console.WriteLine("Он вообще-то умер, бить не может");
			}
		}
	}

    class Program
    {
        static void Main()
        {
	        var monster = new Enemy(10,5, "Дракон Гоша");
	        var saitama = GeneralizedPerson<Person>.GetInstance();
	        saitama.Heal(300);
	        saitama.Damage(30);
	        saitama.Heal(1);
	        saitama.Damage(monster);
	        saitama.Attack(monster);
	        saitama.Respawn();
	        Console.WriteLine(saitama.Hp);
        }
    }
}