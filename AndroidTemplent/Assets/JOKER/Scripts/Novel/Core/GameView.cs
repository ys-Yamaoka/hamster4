

using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace Novel
{

	//ゲームのViewを管理する
	public class GameView{

		public Text messageArea;
        public Text messageAreaPlayer;
        public GameObject messageFrame;
        public GameObject messageFramePlayer;



        public GameView(){

			this.messageArea 		  = (GameObject.Find ("message_area") as GameObject).GetComponent<Text>();
			this.messageFrame 		  = GameObject.Find ("MessageFrame") as GameObject;
            this.messageFramePlayer   = GameObject.Find("MessageFramePlayer") as GameObject;
            this.messageAreaPlayer    = (GameObject.Find("message_area_player") as GameObject).GetComponent<Text>();


        }

        public void hideMessage(float time){

			StatusManager.visibleMessageFrame = false;
			this.messageFrame.SendMessage ("hideMessage", time);
            this.messageFramePlayer.SendMessage("hideMessage", time);
            this.messageArea.SendMessage ("hideMessage", time);
            this.messageAreaPlayer.SendMessage("hideMessage", time);

        }

        public void showMessage(float time){

			StatusManager.visibleMessageFrame = true;
			this.messageFrame.SendMessage ("showMessage", time);
            this.messageFramePlayer.SendMessage("showMessage", time);
            this.messageArea.SendMessage ("showMessage", time);
            this.messageAreaPlayer.SendMessage("showMessage", time);


        }

        public void showMessageWithoutNextOrder(float time){

			StatusManager.visibleMessageFrame = true;
			this.messageFrame.SendMessage ("showMessageWithoutNextOrder", time);
            this.messageFramePlayer.SendMessage("showMessageWithoutNextOrder", time);
            this.messageArea.SendMessage ("showMessage", time);
            this.messageAreaPlayer.SendMessage("showMessage", time);

        }

        public void hideMessageWithoutNextOrder(float time){

			StatusManager.visibleMessageFrame = false;
			this.messageFrame.SendMessage ("hideMessageWithoutNextOrder", time);
            this.messageFramePlayer.SendMessage("hideMessageWithoutNextOrders", time);
            this.messageArea.SendMessage ("hideMessage", time);
            this.messageAreaPlayer.SendMessage("hideMessage", time);

        }




    }

}
