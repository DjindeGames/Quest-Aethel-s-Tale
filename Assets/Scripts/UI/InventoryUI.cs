﻿using UnityEngine;
using TMPro;

namespace Djinde.Quest
{
    public class InventoryUI : MonoBehaviour
    {
        [Header("References")]
        [SerializeField]
        private TMP_Text itemName;
        [SerializeField]
        private TMP_Text itemDetails;
        [SerializeField]
        private TMP_Text goldAmount;
        [SerializeField]
        private TMP_Text oilAmount;


        public static InventoryUI Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            itemName.text = "";
            itemDetails.text = "";
            oilAmount.text = InventoryManager.Instance.OilAmount.ToString();
            goldAmount.text = InventoryManager.Instance.GoldAmount.ToString();
        }

        public void exit()
        {
            ScreenManager.Instance.switchScreen(EScreenType.Main);
        }

        public void showItemDetails(Usable which)
        {
            itemName.text = which.label;
            itemDetails.text = which.details;
            if (which.Type == EItemType.Equipment)
            {
                Equipment equipment = (Equipment)which;
                itemDetails.text += "\n\nBonuses:";
                for (int i = 0; i < equipment._passiveBonuses.Length; i++)
                {
                    itemDetails.text += "\n" + equipment._passiveBonuses[i].type.ToString() + ": " + equipment._passiveBonuses[i].value.ToString();
                }
            }
        }

        public void hideItemDetails()
        {
            itemName.text = "";
            itemDetails.text = "";
        }

        public void setGoldAmount(int amount)
        {
            goldAmount.text = amount.ToString();
        }

        public void setOilAmount(int amount)
        {
            oilAmount.text = amount.ToString();
        }
    }
}