using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PentominosSharp
{
	/// <summary>
	/// 
	/// </summary>
	public class cPiece
	{
		private int[,]	iMatrix;
		private Point[]	thePoints;
		private int		iNumPoints;

		public cPiece()
		{
			
			
			
			iMatrix = new int[5,5];
			iTurns = 0;

		}

		public void CreatePiece(int iPieceType)
		{
			switch(iPieceType)
			{
				case 1:
					iMatrix[0,0] = 0;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;

					piecebrush = new SolidBrush(Color.Blue);

					break;
				case 2:
					iMatrix[0,0] = 0;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 1;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;

					piecebrush = new SolidBrush(Color.Green);
					break;
				case 3:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 1;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;

					piecebrush = new SolidBrush(Color.Yellow);

					break;
				case 4:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 0;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 1;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;

					piecebrush = new SolidBrush(Color.Red);

					break;
				case 5:
					iMatrix[0,0] = 0;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 1;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;

					piecebrush = new SolidBrush(Color.Purple);

					break;

				case 6:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 1;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 1;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 0;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.Magenta);
					break;
				case 7:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 0;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 1;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.Cyan);
					break;
				case 8:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 1;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 0;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 0;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 0;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.Cornsilk);
					break;
				case 9:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 0;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 0;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 1;
					iMatrix[1,3] = 1;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.DarkOrange);
					break;
				case 10:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 0;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 1;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.Pink);
					break;
				case 11:
					iMatrix[0,0] = 0;
					iMatrix[1,0] = 1;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 0;
					iMatrix[1,1] = 1;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 1;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 1;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 0;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.SteelBlue);
					break;
				case 12:
					iMatrix[0,0] = 1;
					iMatrix[1,0] = 0;
					iMatrix[2,0] = 0;
					iMatrix[3,0] = 0;
					iMatrix[4,0] = 0;

					iMatrix[0,1] = 1;
					iMatrix[1,1] = 0;
					iMatrix[2,1] = 0;
					iMatrix[3,1] = 0;
					iMatrix[4,1] = 0;

					iMatrix[0,2] = 1;
					iMatrix[1,2] = 0;
					iMatrix[2,2] = 0;
					iMatrix[3,2] = 0;
					iMatrix[4,2] = 0;

					iMatrix[0,3] = 1;
					iMatrix[1,3] = 0;
					iMatrix[2,3] = 0;
					iMatrix[3,3] = 0;
					iMatrix[4,3] = 0;

					iMatrix[0,4] = 1;
					iMatrix[1,4] = 0;
					iMatrix[2,4] = 0;
					iMatrix[3,4] = 0;
					iMatrix[4,4] = 0;
					piecebrush = new SolidBrush(Color.LightGreen);
					break;
			}

			CreatePoints();

		}

		public void RotatePiece()
		{
			if(iTurns == 4)
			{
				FlipPiece();
				iTurns = 0;
				return;
			}
			iTurns++;
			
			int[,] iTmpMatrix = new int[5,5];
			int i,j;

			for(i=0;i<5;i++)
			{
				for(j=0;j<5;j++)
				{
					iTmpMatrix[j,i] = iMatrix[i,4-j];
				}
			}

			while(iTmpMatrix[0,0] == 0	&&
				iTmpMatrix[1,0] ==	0 &&
				iTmpMatrix[2,0] ==	0 &&
				iTmpMatrix[3,0] ==	0 &&
				iTmpMatrix[4,0] ==	0)
			{
				for(i=0;i<4;i++)
				{
					for(j=0;j<5;j++)
					{
						iTmpMatrix[j,i] = iTmpMatrix[j,i+1];
					}
					iTmpMatrix[i,4] = 0;

				}
			}

			while(iTmpMatrix[0,0] == 0	&&
				iTmpMatrix[0,1] ==	0 &&
				iTmpMatrix[0,2] ==	0 &&
				iTmpMatrix[0,3] ==	0 &&
				iTmpMatrix[0,4] ==	0)
			{
				for(i=0;i<5;i++)
				{
					for(j=0;j<4;j++)
					{
						iTmpMatrix[j,i] = iTmpMatrix[j+1,i];
					}
					iTmpMatrix[4,i] = 0;
				}
			}

			iMatrix = iTmpMatrix;	

			CreatePoints();
		}

		private void CreatePoints()
		{

			const int _RECTSIZE_ = 20;

			Point[] tmpPoints = new Point[100];
			int iPoints = 0, i = 0, j = 0;

			iNumPoints = 0;

			Point[] tmpPoints2 = new Point[36];

			for(i=0;i<5;i++)
			{
				for(j=0;j<5;j++)
				{
					if(iMatrix[j,i] == 0)
					{
						if(j != 0)
						{
							if(iMatrix[j-1,i] == 1)
							{
								tmpPoints[iPoints].X  = (j * _RECTSIZE_);
								tmpPoints[iPoints].Y = (i * _RECTSIZE_);
								iPoints++;

								tmpPoints[iPoints].X = (j * _RECTSIZE_);
								tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
								iPoints++;
							}
						}

						if(j != 4)
						{
							if(iMatrix[j+1,i] == 1)
							{
								tmpPoints[iPoints].X = (j * _RECTSIZE_)+_RECTSIZE_;
								tmpPoints[iPoints].Y = (i * _RECTSIZE_);
								iPoints++;

								tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
								tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
								iPoints++;
							}
						}

						if(i != 0)
						{
							if(iMatrix[j,i-1] == 1)
							{
								tmpPoints[iPoints].X = (j * _RECTSIZE_);
								tmpPoints[iPoints].Y = (i * _RECTSIZE_);
								iPoints++;

								tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
								tmpPoints[iPoints].Y = (i * _RECTSIZE_);
								iPoints++;
							}
						}

						if(i != 4)
						{
							if(iMatrix[j,i+1] == 1)
							{
								tmpPoints[iPoints].X = (j * _RECTSIZE_);
								tmpPoints[iPoints].Y = (i * _RECTSIZE_)+_RECTSIZE_;
								iPoints++;

								tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
								tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
								iPoints++;
							}
						}
					}

					if(j == 0)
					{
						if(iMatrix[j,i] == 1)
						{
							tmpPoints[iPoints].X = (j * _RECTSIZE_);
							tmpPoints[iPoints].Y = (i * _RECTSIZE_);
							iPoints++;

							tmpPoints[iPoints].X = (j * _RECTSIZE_);
							tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
							iPoints++;
						}
					}

					if(j == 4)
					{
						if(iMatrix[j,i] == 1)
						{
							tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
							tmpPoints[iPoints].Y = (i * _RECTSIZE_);
							iPoints++;

							tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
							tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
							iPoints++;
						}
					}

					if(i == 0)
					{
						if(iMatrix[j,i] == 1)
						{
							tmpPoints[iPoints].X = (j * _RECTSIZE_);
							tmpPoints[iPoints].Y = (i * _RECTSIZE_);
							iPoints++;

							tmpPoints[iPoints].X = (j * _RECTSIZE_)+_RECTSIZE_;
							tmpPoints[iPoints].Y = (i * _RECTSIZE_);
							iPoints++;
						}
					}

					if(i == 4)
					{
						if(iMatrix[j,i] == 1)
						{
							tmpPoints[iPoints].X = (j * _RECTSIZE_);
							tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
							iPoints++;

							tmpPoints[iPoints].X = (j * _RECTSIZE_) + _RECTSIZE_;
							tmpPoints[iPoints].Y = (i * _RECTSIZE_) + _RECTSIZE_;
							iPoints++;
						}
					}

				}
			}


			
			Point pBeg, pEnd, pTmp, pCur;

			pEnd = new Point(-10,-10);
			pBeg = new Point(-1,-1);
			pTmp = new Point(-1,-1);
			pCur = new Point();

			while(pBeg.X != pEnd.X && pBeg.Y != pEnd.Y)
			{
				if(pBeg.X == -1 && pBeg.Y == -1)
				{
					
					pBeg = tmpPoints[0];
					tmpPoints2[iNumPoints] = pBeg;
					iNumPoints++;

					pCur = pBeg;
				}


				pTmp = pCur;
				pTmp.X += _RECTSIZE_;

				if(pTmp.X <= _RECTSIZE_ * 5)
				{
					for(i=0;i<iPoints;i++)
					{
						if(tmpPoints[i].X == pTmp.X && tmpPoints[i].Y == pTmp.Y)
						{
							bool bNotFound = true;
							for(j=0;j<iNumPoints;j++)
							{
								if(pTmp.X == tmpPoints2[j].X && pTmp.Y == tmpPoints2[j].Y)
								{
									bNotFound = false;
									j = iNumPoints;
								}
							}

							if(tmpPoints[i].X == pBeg.X && tmpPoints[i].Y == pBeg.Y)
							{
								tmpPoints2[iNumPoints] = tmpPoints[i];
								iNumPoints++;
								pEnd = pBeg;
								i = iPoints;
							}

							if(bNotFound)
							{
								if( (pCur.Y == 0)  &&
									iMatrix[ pCur.X/_RECTSIZE_ == 5 ? 4 : pCur.X/_RECTSIZE_,pCur.Y/_RECTSIZE_] == 1)
								{
									tmpPoints2[iNumPoints] = tmpPoints[i];
									iNumPoints++;
									pCur = tmpPoints[i];
									i = iPoints;
								}
								else
								{
									if((pCur.Y/_RECTSIZE_)-1 < 0)
									{
										if(iMatrix[pCur.X/_RECTSIZE_,pCur.Y/_RECTSIZE_] == 1)
										{
											tmpPoints2[iNumPoints] = tmpPoints[i];
											iNumPoints++;
											pCur = tmpPoints[i];
											i = iPoints;
										}
									}
									else
									{
										if(iMatrix[pCur.X/_RECTSIZE_,(pCur.Y/_RECTSIZE_)-1] == 0 &&
											iMatrix[pCur.X/_RECTSIZE_,pCur.Y/_RECTSIZE_] == 1)
										{
											tmpPoints2[iNumPoints] = tmpPoints[i];
											iNumPoints++;
											pCur = tmpPoints[i];
											i = iPoints;
										}
									}
								}
							}
						}
					}
				}

				if(pCur.X == pTmp.X && pCur.Y == pTmp.Y)
					continue;


				pTmp = pCur;
				pTmp.Y -= _RECTSIZE_;

				if(pTmp.Y >= 0)
				{
					for(i=0;i<iPoints;i++)
					{
						if(tmpPoints[i].X == pTmp.X && tmpPoints[i].Y == pTmp.Y)
						{
							bool bNotFound = true;
							for(j=0;j<iNumPoints;j++)
							{
								if(tmpPoints[i].X == tmpPoints2[j].X && tmpPoints[i].Y == tmpPoints2[j].Y)
								{
									bNotFound = false;
									j = iNumPoints;
								}
							}

							if(tmpPoints[i].X == pBeg.X && tmpPoints[i].Y == pBeg.Y)
							{
								tmpPoints2[iNumPoints] = tmpPoints[i];
								iNumPoints++;
								pEnd = pBeg;
								pCur = tmpPoints[i];
								i = iPoints;
							}


							if(bNotFound)
							{
								if((tmpPoints[i].X/_RECTSIZE_)-1 >= 0)
								{
									if( iMatrix[tmpPoints[i].X/_RECTSIZE_,tmpPoints[i].Y/_RECTSIZE_] + 
										iMatrix[ (tmpPoints[i].X/_RECTSIZE_)-1,tmpPoints[i].Y/_RECTSIZE_] == 1 )
									{
										tmpPoints2[iNumPoints] = tmpPoints[i];
										iNumPoints++;
										pCur = tmpPoints[i];
										i = iPoints;
									}
								}
								else
								{
									if( iMatrix[tmpPoints[i].X/_RECTSIZE_,tmpPoints[i].Y/_RECTSIZE_] == 1 )
									{
										tmpPoints2[iNumPoints] = tmpPoints[i];
										iNumPoints++;
										pCur = tmpPoints[i];
										i = iPoints;
									}
								}
							}
						}
					}
				}

				if(pCur.X == pTmp.X && pCur.Y == pTmp.Y)
					continue;


				pTmp = pCur;
				pTmp.Y += _RECTSIZE_;


				if(pTmp.Y <= _RECTSIZE_ * 100)
				{
					for(i=0;i<iPoints;i++)
					{
						if(tmpPoints[i].X == pTmp.X && tmpPoints[i].Y == pTmp.Y)
						{
							bool bNotFound = true;
							for(j=0;j<iNumPoints;j++)
							{
								if(tmpPoints[i].X == tmpPoints2[j].X && tmpPoints[i].Y == tmpPoints2[j].Y)
								{
									bNotFound = false;
									j = iNumPoints;
								}
							}

							if(tmpPoints[i].X == pBeg.X && tmpPoints[i].Y == pBeg.Y)
							{
								tmpPoints2[iNumPoints] = tmpPoints[i];
								iNumPoints++;
								pEnd = pBeg;
								i = iPoints;

							}

							if(bNotFound)
							{
								if(tmpPoints[i].X/_RECTSIZE_ == 5)
								{
									tmpPoints2[iNumPoints] = tmpPoints[i];
									iNumPoints++;
									pCur = tmpPoints[i];
									i = iPoints;
								}
								else
								{
									if(iMatrix[ (tmpPoints[i].X/_RECTSIZE_)   ,
										(tmpPoints[i].Y/_RECTSIZE_)-1] == 0 && 
										iMatrix[ (tmpPoints[i].X/_RECTSIZE_)-1   ,
										(tmpPoints[i].Y/_RECTSIZE_)-1] == 1
										)
									{
										tmpPoints2[iNumPoints] = tmpPoints[i];
										iNumPoints++;
										pCur = tmpPoints[i];
										i = iPoints;
									}
								}
							}
						}
					}
				}


				if(pCur.X == pTmp.X && pCur.Y == pTmp.Y)
					continue;

				pTmp = pCur;
				pTmp.X -= _RECTSIZE_;

				for(i=0;i<iPoints;i++)
				{
					if(tmpPoints[i].X == pTmp.X && tmpPoints[i].Y == pTmp.Y)
					{
						bool bNotFound = true;

						for(j=0;j<iNumPoints;j++)
						{
							if(tmpPoints[i].X == tmpPoints2[j].X && tmpPoints[i].Y == tmpPoints2[j].Y)
							{
								bNotFound = false;
								j = iNumPoints;
							}
						}

						if(tmpPoints[i].X == pBeg.X && tmpPoints[i].Y == pBeg.Y)
						{
							tmpPoints2[iNumPoints] = tmpPoints[i];
							iNumPoints++;
							pEnd = pBeg;
							i = iPoints;

						}

						if(bNotFound)
						{
							tmpPoints2[iNumPoints] = tmpPoints[i];
							iNumPoints++;
							pCur = tmpPoints[i];
							i = iPoints;
						}
					}
				}
			}	

			thePoints = new Point[iNumPoints];
			
			for(i=0;i<iNumPoints;i++)
			{
				thePoints[i] = tmpPoints2[i];
			}

		}

		public void Draw( Graphics oGraph)
		{
			Pen blackpen = new Pen(Color.Black, 2);

			


			Point[] tmpPoints = (Point[]) thePoints.Clone();

			for(int i=0;i<iNumPoints;i++)
			{
				tmpPoints[i].X += iPosX;
				tmpPoints[i].Y += iPosY;
			}

			
			
			oGraph.DrawPolygon(blackpen, tmpPoints);
			oGraph.FillPolygon(piecebrush, tmpPoints, FillMode.Winding);

			blackpen.Dispose();
		}

		public int iPosX;
		public int iPosY;

		public void SetPos(int iX, int iY)
		{
			iPosX = iX;
			iPosY = iY;
		}

		public SolidBrush piecebrush;

		public bool Hitted(int iX, int iY)
		{
			for(int i=0;i<5;i++)
			{
				for(int j=0;j<5;j++)
				{
					if(iMatrix[i,j] == 1)
					{
						if(iX  == iPosX + (i*20) && iY  == iPosY + (j*20))
							return true;
					}
				}
			}
			
			return false;
		}

		public int GetX()
		{
			return iPosX;
		}

		public int GetY()
		{
			return iPosY;
		}

		public int GetWidth()
		{
			int iGreater = 0;

			for(int j=0;j<5;j++)
			{
				for(int i=0;i<5;i++)
				{
					if(iMatrix[i,j] == 1)
					{
						if(i > iGreater)
							iGreater = i;
					}
				}
			}

			return (iGreater+1)*20;
		}

		public int GetHeight()
		{
			int iGreater = 0;

			for(int j=0;j<5;j++)
			{
				for(int i=0;i<5;i++)
				{
					if(iMatrix[i,j] == 1)
					{
						if(j > iGreater)
							iGreater = j;
					}
				}
			}

			return (iGreater+1)*20;

		}

		public void FlipPiece()
		{
			int[,] iTmpMatrix = new int[5,5];
			int i,j;

			for(i=0;i<5;i++)
			{
				for(j=0;j<5;j++)
				{
					iTmpMatrix[j,i] = iMatrix[4-j,i];
				}
			}

		

			while(iTmpMatrix[0,0] == 0	&&
				iTmpMatrix[0,1] ==	0 &&
				iTmpMatrix[0,2] ==	0 &&
				iTmpMatrix[0,3] ==	0 &&
				iTmpMatrix[0,4] ==	0)
			{
				for(i=0;i<5;i++)
				{
					for(j=0;j<4;j++)
					{
						iTmpMatrix[j,i] = iTmpMatrix[j+1,i];
					}
					iTmpMatrix[4,i] = 0;
				}
			}

			iMatrix = iTmpMatrix;	

			CreatePoints();		
		}

		public int iTurns;
	}
}
