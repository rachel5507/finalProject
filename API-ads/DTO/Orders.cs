using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Orders//������
    {
     public int ClientTz { get; set; }//�� ����
     public int TemplateKod { get; set; }//��� �����
     public DateTime StartDate { get; set; }//����� ����� ������
     public DateTime EndDate { get; set; }//����� ���� ������
     public string Advertisement { get; set; }// ����� ������� ������� �����


    }
}
