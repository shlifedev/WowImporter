﻿# Caladia Guild

더 길드2를 모티브로한 시뮬레이션 게임입니다. 


현실에 존재하지 않는 중세 기반의 가상 세계관에서 생산, 무역, 외교, 전투, 간계 등
여러가지 컨텐츠를 즐길 수 있습니다.

# 구현 예정사항
 
 먼저 지역간 무역 시스템을 읽어보십시오. 당신은 내가 만들고있는 게임에 대해서, 컨셉에 대해서
 충분히 이해할 수 있게됩니다.

 모든 시스템에 대해서 복잡하게 설명할 수 없지만 지역간 무역 시스템이 이 게임이 얼마나 디테일함을
 가지고 있는지 알 수 있게 해줍니다.

## 지역간 무역 시스템

 칼라디아는 항상 물자가 부족합니다 특히, 게임이 진행되면 진행될수록 인구수가 증가하고 
 도시는 발전합니다. 도시의 행복을 위해 각 사회 계층 별 각 인구가 필요로하는 필수재들이 존재하고, 
 이 시스템은 생각보다 복잡하게 동작합니다.
 
 특정한 평가 시스템에 의해 시민 행복도와 도시 부유, 전체 행복도가 결정되며 출산율이나 전쟁, 기아,
 질병 등 여러가지 요소에 복잡하게 작용합니다.

 예를 들어 일반 시민은 각 날짜별로 평균 2-3개의 식량을 소비합니다.
 인구가 100명이라 가정하면, 도시는 하루마다 200개의 식량이 필요로하며, 300개에 가깝거나 그 이상의 식량이라면
 도시는 번영도가 높아지며 번영을 하게 됩니다.

 인구 100명의 도시를 유지해야한다고 가정해봅시다. 그리고 단순화를 위해 이 도시는 빵만 먹는 빵도시라고 생각을 해봅시다.
 
 빵을 생산하는데 있어서 밀가루라는 원재료를 타 도시에서 무역품을 들여오는데에 3일의 시간이 소요되고
 빵 200개를 생산하는데에 1일이 걸린다면 이 도시는 4일마다 빵을 200개 생산하고, 하루마다 빵을 200개씩(1인당 2개) 소비하기때문에
 매우 식량이 부족한 도시입니다. 3일의 공백이 생기기 때문입니다.

 즉, 이 도시는 망합니다. 해결 방법은 여러가지가 있습니다. 
 1. 원재료를 자체 생산하는 도시로 만들거나
 2. 무역품을 한번에 많이 수입해오는 방법을 연구하거나 
 3. 출산 제한 정책을 만들거나
 4. 전쟁, 약탈을 통해 식량을 공수해오거나
  (모든 도시는 시스템에의해 통제되기 때문에 전쟁에서 큰 손해를 본 도시는 망할수도 있습니다.
   즉, 전쟁은 모두에게 이득이 되지 못합니다.. )
 5. 등급은 낮지만 바로 소비할 수 있는 식품 (생선 등)을 생산하는 곳을 만들거나..

 여러가지 방법이있고, 플레이 방법은 당신에게 달려 있습니다.
 
 # 생산
  높은 생산품을 만들려면 학력이 높은 시민들이 필요합니다.
  특정한 생산품을 시민 등급에 영향을 받습니다. 예를들면 상급시민은 아무도 나무베는 단순노동을 하고싶어 하지 않을 것 입니다. (하지만, 현실성 반영을 위해 가끔 나무베는걸 좋아하는 힘 쓰는걸 좋아하는 특이한? 녀석들이 나타납니다.)
  
 # 사회적 문제
  인종 차별, 성 차별, 성격 차별, 지역 차별 여러가지 문제들이 발생할 수 있습니다.
  나는 이러한 차별을 현실에서 매우 싫어하지만, 난 우리 세계에서 일어날 수 있는 일들을 게임에 만들어보고 싶었습니다.
  하지만 모든 사람이 차별을 하는것은 아니며 차별 문화는 국가와 정부가, 그리고 각 개인이 고쳐나가야 하는 사회적 문제입니다.

  범죄 또한 마찬가지입니다. 부패한 정치인





 하지만 게임 내 전체 도시의 식량 생산 건물(빵집 등) 에서 최소 식량 요구치를 충족하지 못한경우
 시민이 병에들고, 죽고, 시간이 흐름에따라 자연스럽게 인구수가 줄어들고 도시 번영도는 낮아집니다.
 
 심지어 각 식량에는 가치가 기록됩니다. 같은 고기여도 등급이 있으며, 같은 빵이도 다른 등급이 있고
 등급이 낮은 저품질의 식량이 도시에 유통되는경우 (최악의 경우지만) 식중독, 혹사병등이 발생할 수 있으며
 고위직급에 있는 귀족과 같은 시민들은 일반 시민들과 비슷한 식사를 하고싶지 않아 할 것 입니다.
  
 추후 수천 수만 수십만의 인구가 된다고 생각해보십시오. 이러한 경우 최적화 문제가 있습니다.
 각 개별 인구가 가지는 프로퍼티와 복잡한 로직들이 많아지지 않는게 좋습니다.


 ## 모딩 환경(확장성)
  난 내가만든 이 게임이 매우 천재적이라 생각합니다.
  AI시스템을 기반으로한 하나의 사회라고 생각합니다.

  당신이 이 게임에 연쇄 살인마라는 AI를 추가하는 순간, 나쁜 시민이 분명 생길것입니다.
  이 연쇄 살인마를 잡기 위한 조건들을 충족하는 방법을 만들어야 할것이고(치안과 관련한 AI를 만들어야겠죠?)
  아니면 이 녀석은 끊임없이 당신의 사회를 훼손할 것 입니다.

  모든 시민은 비슷한 상태들을 가지지만 (아침에 일어나 출근하고 집에와서 자는 당신의 삶처럼..)
  그 속에서도 본인 개인의 주변 환경(인간관계), 사물등에 의해 많은 변화가 있을겁니다.

  학교 등교를 위해 집에서 등교하는 어린이 주민이 등교하고 있는데
  하필이면 집과 학교 루트 사이에서 귀여운 고양이가 주변을 배회하고 있었습니다.
  이 어린이의 성향이 동물 친화적이라면 고양이를 쫓다가 학교에 지각할 수 있기도 하고요.
  정말 모든 주민마다 성향이 너무 너무 다르기 때문에 아무것도 예측할 수 없습니다.
  하지만 이러한 디테일함이 전체 사회에 큰 문제를 끼치진 않습니다. 예측 가능한 범위에서 행동합니다.
  고양이를 잠깐 예뻐한다고, 학교에 반드시 지각할 리 없고
  학교에 하루 이틀 몇 분 정도 지각한다고 큰 문제가 생길리는 없습니다.
   
  당신은 이 어린이 AI에 재미난 기능을 추가하고 싶을수도 있습니다.
  가끔은 결석하고 학교 가야 할 시간에 놀이터에서 놀 고 잇는 것이지요.
  하지만 주변에 놀이터가 없다면 이런 이벤트도 발생하지 않을 수 있는것이구요..
  모더가 정말 많은 기능을 자유롭게 추가할 수 있습니다.

  대체로 모든 부분이 모듈화 되어있기 때문에 모더는 단순히 해당 모듈만 변경하는 되는 구조입니다.
  예를 들어 당신이 교회건물의 AI를 변경하고 싶다면 모더는 교회의 AI 시스템 코드만 교체하면 됩니다.
  
  8시부터 12시까지 예베 시간이었던 부분을 9시부터 12시로 변경하고 싶습니까?
  이러한 부분은 코드 변경이 아닌 데이터의 변경으로도 기존 시스템 동작사항을 변경할 수 있습니다.
   
  하지만 복잡한 시뮬레이션 환경에 의해 특정 요소가 빠지거나 했을때 시간 흐름에 따라 게임 전체에
  끼치는 영향을 파악하기는 힘듭니다.

  예를 들어 게임 이해도가 낮은 모더가 무역품 시스템에서 무역품의 모든 등급을 '최상급' 으로 변경했을때
  모든 도시는 이 무역품을 '소비' 할 수 있는 소비자가 없기때문에, 심지어 생산시설을 보유한 고위 공직자 시민 AI또한
  생산에 필요한 원재료가 너무 비싸 최종 결과물을 소비가에 맞출 수 없고 그로인해 생산 시설이 망해버리기 때문에
  결국 시간의 흐름에따라 도시는 반란, 붕괴 상태에 빠질 것 입니다. 

  게임 시스템을 변경한다면 게임 이해도가 높은 플레이어가 변경하는걸 추천합니다.
  편의성을 개선하는 등의 간단한 모딩부터 시작해보십시오.

  




 ## 모딩 환경(레거시 호환성)
 
  GetUserData -> GetUserInfo 와 같은 변동사항이 있다고 가정합니다. 
  하지만 기존 함수는 C# Attribute에 의해 API마다 고유한 인덱스가 수동 지정되어있기 때문에
  모더가 올바른 지침을 따랐다면 레거시 모드에는 아무런 문제가 없어야합니다. (시스템 변경이 있지 않은경우)



