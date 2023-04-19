namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiwanCity")]
    public partial class TaiwanCity
    {
        [Key]
        public int TaiwanCityTID { get; set; }

        [Required]
        [StringLength(15)]
        public string? CityCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? CityName { get; set; }

        public int CityOrder { get; set; }

        [Required]
        [StringLength(25)]
        public string? CityStatus { get; set; }

        public bool deleted { get; set; } = false;
    }
    //�x�W��F��
    public partial class TaiwanDist
    {
        [Key]
        public int id { get; set; }
        [StringLength(15), Display(Name = "�����s��"), Required]
        public string? CityCode { get; set; }
        [StringLength(15), Display(Name = "�m���Ͻs��")]
        public string? DistCode { get; set; }
        [StringLength(15), Display(Name = "�m���ϦW��"), Required]
        public string? DistName { get; set; }
        [StringLength(25)]
        public string? status { get; set; } = "Active";
        public bool deleted { get; set; } = false;
    }
}
/*
 area_data = {
    'TPE': [
        '������', '�j�P��', '���s��', '�U�ذ�', '�H�q��', '�Q�s��', '�j�w��', '�n���', '�_���', '�����', '�h�L��', '��s��'
    ],
    'TPH': [
        '�O����', '�s����', '���s��', '�L�f��', '�H����', '���s��', '�K����', '�U����', '�۪���', '�T�۰�', '��ڰ�', '�����', '���˰�', '�^�d��', '���˰�', '�`�|��', '�����', '�s����', '�W�L��', '�Q�Ӱ�', '���M��', '�éM��', '�g����', '�T�l��', '��L��', '�a�q��', '�T����', 'Ī�w��', '���Ѱ�'
    ],
    '	KLU': [
        '���R��', '������', '�H�q��', '���s��', '�w�ְ�', '�x�x��', '�C����'
    ],
    'TYC': [
        '����', '���c��', '������', '�K�w��', '������', 'Ī�˰�', '�t�s��', '�s���', '�j�˰�', '�j���', '�[����', '�s�ΰ�', '�_����'
    ],
    'HSH': [
        '�˥_��', '�˪F��', '�s�H��', '������', '�o�ܶm', '�_�s�m', '�_�H�m', '��s�m', '�|�L�m', '��f�m', '�s�׶m', '�y�۶m', '���p�m'
    ],
    'HSC': [
        '�F��', '�_��', '���s��'
    ],
    'MAC': [
        '�]�ߥ�', '�q�]��', '�b����', '�˫n��', '�Y����', '���s��', '������', '���m', '�Y�ζm', '���]�m', '���r�m', '�T�q�m', '�y���m', '�T�W�m', '�n�ܶm', '�j��m', '���m', '���w�m'
    ],
    'TXG': [
        '����', '�F��', '�n��', '���', '�_��', '�_�ٰ�', '��ٰ�', '�n�ٰ�', '�ӥ���', '�j����', '���p��', '�Q���', '�׭��', '�Z����', '�F�հ�', '�۩���', '�s����', '�M����', '������', '��l��', '�j����', '�j�{��', '�s����', '�F����', '��ϰ�', '�M����', '�j�Ұ�', '�~�H��', '�j�w��'
    ],
    'NTC': [
        '�n�륫', '�H����', '�����', '�ˤs��', '������', '�W���m', '�����m', '���d�m', '�����m', '��m�m', '�����m', '�H�q�m', '���R�m'
    ],
    'CWH': [
        '���ƥ�', '���L��', '�M����', '������', '�˴���', '�G�L��', '�Ф���', '�_����', '��¶m', '���m', '�j���m', '�ùt�m', '����m', '�u��m', '�ֿ��m', '�q���m', '�H�߶m', '�H�Q�m', '�j���m', '�ڭb�m', '�˶��m', '���Y�m', '�G���m', '�Ч��m', '���Y�m', '�˦{�m'
    ],
    'YLH': [
        '�椻��', '��n��', '�����', '������', '�g�w��', '�_����', '�l��m', '�L���m', '�j�|�m', '�j��m', '�[�I�m', '�G�[�m', '���d�m', '�O��m', '�F�նm', '�ǩ��m', '�|��m', '�f��m', '���L�m', '�����m'
    ],
    'CHY': [
        '�ӫO��', '���l��', '���U��', '�j�L��', '�����m', '�ˤf�m', '�s��m', '���}�m', '�F�۶m', '�q�˶m', '����m', '���W�m', '���H�m', '�˱T�m', '���s�m', '�f���m', '�j�H�m', '�����s�m'
    ],
    'CYI': [
        '�F��', '���'
    ],
    'TNN': [
        '�����', '�F��', '�n��', '�_��', '�w����', '�w�n��', '�ñd��', '�k����', '�s�ư�', '������', '�ɤ���', '�����', '�n�ư�', '���w��', '���q��', '�s�T��', '�x�а�', '�¨���', '�Ψ���', '����', '�C�Ѱ�', '�N�x��', '�ǥҰ�', '�_����', '�s���', '�����', '�ժe��', '�F�s��', '���Ұ�', '�U���', '�h���', '�Q����', '���ư�', '�j����', '�s�W��', '�s����', '�w�w��'
    ],
    'KHH': [
        '�����', '�����', '���s��', '�T����', '�Q�L��', '�e����', '�s����', '�d����', '�e����', '�p���', '�X�z��', '��s��', '�j�d��', '���Q��', '�L���', '���Z��', '�j���', '�j����', '���s��', '���˰�', '���Y��', '��x��', '������', '�æw��', '�P�_��', '�мd��', '������', '�X�_��', '�򤺰�', '�X�s��', '���@��', '������', '���L��', '�ҥP��', '���t��', '�Z�L��', '�緽��', '�����L��'
    ],
    'IUH': [
        '�̪F��', '��{��', '�F����', '���K��', '�U���m', '���v�m', '�ﬥ�m', '�E�p�m', '����m', '�Q�H�m', '����m', '�U�r�m', '���H�m', '�˥жm', '�s��m', '�D�d�m', '�s��m', '�r���m', '�L��m', '�n�{�m', '�ΥV�m', '�[�y�m', '�����m', '���{�m', '�D�s�m', '���x�m', '���a�m', '���Z�m', '�Ӹq�m', '�K��m', '��l�m', '�d���m', '�T�a���m'
    ],
    'ILN': [
        '�y����', 'ù�F��', 'Ĭ�D��', '�Y����', '�G�˶m', '����m', '���s�m', '�V�s�m', '�����m', '�T�P�m', '�j�P�m', '�n�D�m'
    ],
    'HWA': [
        '�Ὤ��', '��L��', '�ɨ���', '�s���m', '�N�w�m', '���׶m', '�q�L�m', '���_�m', '���ضm', '���J�m', '�U�a�m', '�I���m', '���˶m'
    ],
    'TTT': [
        '�O�F��', '���\��', '���s��', '���ضm', '���ݶm', '���W�m', '�F�e�m', '�����m', '�����m', '���n�m', '���p�m', '�j�Z�m', '�F���m', '��q�m', '�����m', '�ӳ¨��m'
    ],
    'PEH': [
        '������', '���m', '�ըF�m', '�����m', '��w�m', '�C���m'
    ],
    'KMN': [
        '������', '������', '���F��', '����m', '�P���m', '�Q���m'
    ],
    'LNN': [
        '�n��m', '�_��m', '�����m', '�F�޶m'
    ]
}
 */