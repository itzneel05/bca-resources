class bestmy extends Thread {
    String str;
    public bestmy(String str){
        this.str = str;
    }
    @Override
    public void run(){
        if(str=="Best"){
            for(int i = 0;i<5;i++){
                System.out.print("BEST ");
                try {
                    Thread.sleep(1000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
        if(str=="Of"){
            for(int i = 0;i<5;i++){
                System.out.print("OF ");
                try {
                    Thread.sleep(1000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
        if(str=="Luck"){
            for(int i = 0;i<5;i++){
                System.out.print("LUCK ");
                try {
                    Thread.sleep(1000);
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}
public class Basic_Thread_v4 {
    public static void main(String[] args) {
        bestmy b1 = new bestmy("Best");
        bestmy b2 = new bestmy("Of");
        bestmy b3 = new bestmy("Luck");
        b1.start();
        b2.start();
        b3.start();
    }
}
