﻿using simplepa2.UI.Components;
using simplepa2.UI.Popups;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;

namespace simplepa2.UI.Views
{
    public partial class View_BBCSite : Wisej.Web.UserControl
    {
        private Random random = new Random();

        private int EMDeviceID = 2;     // 필요시 변경가능 기능으로 처리 (향후), 현재 E.M 은 2번으로 정리되어 있음 
        
        // 우측 사이트 입력폼 
        private Comp_SiteDetailForm comp_SiteDetailForm;        

        // 사이트 UI 카드 객체 리스트 
        private List<Comp_SiteCard> siteCardList = new List<Comp_SiteCard>();

        public View_BBCSite()
        {
            InitializeComponent();


        }
        public void reDraw()
        {
            // 1. 데이터 로드
            siteDataReLoad();

            // 2, 사이트 카드 로드  > 이후 이벤트로 처리 과정 (카드 클릭)
            setupSiteCardData();
        }

        /* 필요한 데이터를 DB 에서 받아  DataSet11에 Fill 하는  과정  */
        public void siteDataReLoad()
        {
            try
            {      
                this.emServerNDeviceNameTableAdapter1.Fill(this.dataSet11.EMServerNDeviceName);
            }
            catch(Exception e)
            {
                MessageBox.Show("LAW TEXT : BBC 사이트의 데이터를 로드하는 중 예외 발생 - " + e.ToString());
            }
            
        }
        
        private void setupSiteCardData()
        {
            if(this.dataSet11.EMServerNDeviceName.Count == 0)                
            {
                MessageBox.Show("LAWTEXT : 선번장 입력 후 장비스캔이 완료된 경우 사이트 정보가 표시됩니다.");
                this.Dispose();
                return;
            }

            try
            {
                foreach (var siteData in this.dataSet11.EMServerNDeviceName)
                {
                    this.siteCardList.Add(new Comp_SiteCard(siteData));
                }

                foreach (Comp_SiteCard card in siteCardList)
                {
                    card.verifyClick += new Comp_SiteCard.CompSiteCardVerify(this.siteCardVerifyClick);
                    this.fpn_sitePanel.Controls.Add(card);
                }
            } catch (Exception e)
            {
                MessageBox.Show("LAW TEXT : BBC 사이트의 카드를 만는 과정에서 예외 발생 - " + e.ToString());
            }            
        }

        private void View_BBCSite_Load(object sender, EventArgs e)
        {
            reDraw();
        }

        /*사이트 카드를 셋업 해주는 기능 */
        private void siteCardVerifyClick(object sender, Comp_SiteCard.CompSiteCardVerifyClickedEventArgs args)
        {
            var site_index = args.site_index;
            // 01. 사용자가 눌른 사이트 번호 알기 args 에서 
            try
            {
                foreach (var siteData in this.dataSet11.EMServerNDeviceName)
                {
                    if(siteData.EMServerId == site_index)
                    {
                        setupSiteFormView(siteData);
                    }
                }

            } catch (Exception e)
            {
                MessageBox.Show("LAW TEXT : BBC 사이트를 클릭하여 로드 하는 중  예외 발생 - " + e.ToString());
            }

            // 02. DB 데이터에서 해당 데이터를 Pack 하여 Form 에 넣기 

        }


        /*사이트 View 폼을 셋업 해주는 기능 */
        private void setupSiteFormView(DataRow emSiteDataSet) 
        {
            try
            {
                if (comp_SiteDetailForm == null)
                {
                    comp_SiteDetailForm = new Comp_SiteDetailForm(emSiteDataSet);
                    this.pn_contents.Controls.Add(comp_SiteDetailForm);
                }
                else
                {
                    comp_SiteDetailForm.initUIBySiteData(emSiteDataSet);
                }
            } catch (Exception e)
            {
                MessageBox.Show("LAW TEXT : BBC 사이트의 DetailForm(우측)을 로드하는 중 예외 발생 - " + e.ToString());
            }
        }
        
        /* 신규 사이트를 만드는 버튼을 눌렀을 경우 */ 
        private void bt_siteAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("구현사항 : 사이트 추가 폼 클린");
            comp_SiteDetailForm.setupNewSiteGeneration();
        }


    }
}
