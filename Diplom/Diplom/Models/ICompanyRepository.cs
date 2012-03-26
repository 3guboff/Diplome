﻿using System.Collections.Generic;
using System.Linq;

namespace Diplom.Models
{
    public interface ICompanyRepository
    {
        Company GetBy(int id);
        List<Company> GetAll();
        int Save(Company company);
    }

    public class CompanyRepositoryFake : ICompanyRepository
    {
        private static Dictionary<int, Company> companies = new Dictionary<int, Company>
                                                                {
                                                                    {
                                                                        1, new Company
                                                                               {
                                                                                   Id = 1,
                                                                                   Name =
                                                                                       "Городская клиническая больница № 31",
                                                                                   Description =
                                                                                       "Мадина: \"Прочитала в интернете отзывы о различных салонах красоты. Отзывы о салоне \"Sunshine\" меня очень впечатлили. Поэтому я решила сделать свое долгожданное ламинирование там. Прежде чем заплатить немаленькую сумму денег, я решила проконсультироваться …",
                                                                                   Address = "Курляндская, 20",

                                                                               }
                                                                        },

                                                                    {
                                                                        2, new Company
                                                                               {
                                                                                   Id = 2,
                                                                                   Name =
                                                                                       "Городская клиническая больница № 31",
                                                                                   Description =
                                                                                       "Мадина: \"Прочитала в интернете отзывы о различных салонах красоты. Отзывы о салоне \"Sunshine\" меня очень впечатлили. Поэтому я решила сделать свое долгожданное ламинирование там. Прежде чем заплатить немаленькую сумму денег, я решила проконсультироваться …",
                                                                                   Address = "Курляндская, 20",

                                                                               }
                                                                        },                                                                    {
                                                                        3, new Company
                                                                               {
                                                                                   Id = 3,
                                                                                   Name =
                                                                                       "Городская клиническая больница № 31",
                                                                                   Description =
                                                                                       "Мадина: \"Прочитала в интернете отзывы о различных салонах красоты. Отзывы о салоне \"Sunshine\" меня очень впечатлили. Поэтому я решила сделать свое долгожданное ламинирование там. Прежде чем заплатить немаленькую сумму денег, я решила проконсультироваться …",
                                                                                   Address = "Курляндская, 20",

                                                                               }
                                                                        },
                                                                };
        public Company GetBy(int id)
        {
            if (companies.ContainsKey(id) == false)
                return null;
            return companies[id];
        }

        public List<Company> GetAll()
        {
            return companies.Select(c => c.Value).ToList();
        }

        public int Save(Company company)
        {
            if (company.Id == 0)
            {
                int maxId = companies.Count == 0 ? 0 : companies.Keys.Max();
                company.Id = maxId + 1;
            }

            if (companies.ContainsKey(company.Id))
            {
                companies[company.Id] = company;
            }
            else
            {
                companies.Add(company.Id, company);
            }

            return company.Id;
        }
    }
}