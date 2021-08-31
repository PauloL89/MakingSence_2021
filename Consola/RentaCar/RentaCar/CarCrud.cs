using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{

	class CarCrud
    {

		private string jsonFile = @"C:\Users\Paulo_PC\source\repos\Making Sense\Consola\RentaCar\RentaCar\Cars.json";
		List<Car> listCar = new List<Car>();

		public void Create(Car car)
		{
			Load();
			listCar.Add(car);
			Save();
			
		}

		public void Save()
		{
            
			string json = JsonConvert.SerializeObject(listCar);
			File.WriteAllText(jsonFile, json);
			
		}

		public void Load()
		{
			string json = File.ReadAllText(jsonFile);
			listCar = JsonConvert.DeserializeObject<List<Car>>(json);
		}

		public void Get(int id)
		{
			

			StreamReader r = new StreamReader(jsonFile);
			string json = r.ReadToEnd();
			List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(json);
            foreach (var item in carList)
            {
				if (item.idCar == id)
				{

					Console.WriteLine(item.ToStringCar());
				}
				
			}
			r.Close();
        }

		public void GetAll()
		{
			StreamReader r = new StreamReader(jsonFile);
			string json = r.ReadToEnd();
			List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(json);
			foreach (var item in carList)
			{
				Console.WriteLine(item.ToStringCar());
			}
			r.Close();
		}

		public void Update(Func<Car, bool> id, Car carUpdate)
		{
			Load();
			listCar = listCar.Select( x => 
			{
				if (id(x)) x = carUpdate;
				return x;
			}).ToList();
			Save();
			
			
		}

		public void Delete(Func<Car,bool> id)
		{
			Load();
			listCar = listCar.Where(x => !id(x)).ToList();
			Save();
			
		}

		
	}
}
