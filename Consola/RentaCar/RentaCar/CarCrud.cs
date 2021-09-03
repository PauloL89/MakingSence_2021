using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar
{

	class CarCrud
    {

		private string jsonFile = ConfigurationManager.AppSettings[("jsonFilePath")];
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

            using (StreamReader r = new StreamReader(jsonFile))
            {
				string json = r.ReadToEnd();
				List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(json);
				foreach (var item in carList)
				{
					if (item.idCar == id)
					{

						Console.WriteLine(item.ToStringCar());
					}

				}
			}
					
        }

		public void GetAll()
		{
            using (StreamReader r = new StreamReader(jsonFile))
            {
				string json = r.ReadToEnd();
				List<Car> carList = JsonConvert.DeserializeObject<List<Car>>(json);
				foreach (var item in carList)
				{
					Console.WriteLine(item.ToStringCar());
				}
			}
			
			
		}

		

		public void Update(int id, Car car)
		{
			Load();
			
            foreach (var item in listCar)
            {
				if(item.idCar == id) 
				{
					item.idCar = car.idCar;
					item.Model = car.Model;
					item.Doors = car.Doors;
					item.brand = car.brand;
					item.color = car.color;
					item.box = car.box;
				}
				
            }
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
